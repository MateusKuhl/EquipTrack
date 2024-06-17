<?php
include_once "./connect.php";

$nome = $_POST['nomeR'];
$acessorios = $_POST['acessoriosR'];
$bloco = $_POST['blocoR'];
$sala = $_POST['salaR'];
$data = $_POST['dataR'];
$hora = $_POST['horaR'];
$idfuncionario = 0;
$quantidade = 0;

$sql = "SELECT TOP 1 id_Funcionario FROM funcionario f WHERE nome_Funcionario like '%$nome%'";
$stmt = sqlsrv_query($conn, $sql);
if( $stmt === false) {
    die( print_r( sqlsrv_errors(), true) );
}
if( $row = sqlsrv_fetch($stmt) == false) {
    die("<script>alert('Funcionário não cadastrado!'); window.location.href='http://localhost/WebBoot/reservar.php';</script>"); 
}

$idfuncionario = sqlsrv_get_field($stmt, 0);

$sql = "SELECT COUNT(*) AS quantidade FROM agenda_funcionario af WHERE horario = '$hora' AND data_Agendamento = CAST('$data' as DATE) AND id_Funcionario = $idfuncionario";
$stmt = sqlsrv_query($conn, $sql);
if( $stmt === false) {
    die( print_r( sqlsrv_errors(), true) );
}

while( $row = sqlsrv_fetch_array( $stmt, SQLSRV_FETCH_ASSOC) ) {
    $quantidade = $row['quantidade'];
}

if($quantidade > 0)
{
    die("<script>alert('Horário já ocupado!'); window.location.href='http://localhost/WebBoot/reservar.php';</script>");
}

$sqlInsert = "INSERT INTO agenda_funcionario (id_Funcionario, data_Agendamento, horario, situacao_Agendamento, bloco, sala) values ($idfuncionario, '$data', '$hora', 'MARCADO', '$bloco', '$sala')";
$stmt = sqlsrv_query($conn, $sqlInsert);

$sqlInsert = "INSERT INTO item_agenda (id_Item, id_Agendamentos, quantidade_Itens) values ($acessorios, (SELECT MAX(id_Agendamentos) AS QUANTIDADE FROM agenda_funcionario), 1)";
$stmt = sqlsrv_query($conn, $sqlInsert);

echo "<script>alert('Reserva realizada com sucesso!'); window.location.href='http://localhost/WebBoot/menu.html';</script>";