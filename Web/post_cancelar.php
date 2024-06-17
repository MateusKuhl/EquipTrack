<?php
include_once "./connect.php";

$nome = $_POST['nomeC'];
$acessorios = $_POST['acessoriosC'];
$bloco = $_POST['blocoC'];
$sala = $_POST['salaC'];
$data = $_POST['dataC'];
$hora = $_POST['horaC'];
$idfuncionario = 0;
$quantidade = 0;

$sql = "SELECT TOP 1 id_Funcionario FROM funcionario f WHERE nome_Funcionario like '%$nome%'";

$stmt = sqlsrv_query($conn, $sql);
if( $stmt === false) {
    die( print_r( sqlsrv_errors(), true) );
}
if( $row = sqlsrv_fetch($stmt) == false) {
    die("<script>alert('Funcionário não cadastrado!'); window.location.href='http://localhost/WebBoot/cancelar.php';</script>"); 
}

$idfuncionario = sqlsrv_get_field($stmt, 0);

$sql = "DELETE item_agenda WHERE id_Agendamentos = (SELECT MAX(id_Agendamentos) FROM agenda_funcionario WHERE data_Agendamento = CAST('$data' as DATE) AND id_Funcionario = $idfuncionario)";
$stmt = sqlsrv_query($conn, $sql);
if( $stmt === false) {
    die( print_r( sqlsrv_errors(), true) );
}

$sql = "DELETE agenda_funcionario WHERE horario = '$hora' AND data_Agendamento = CAST('$data' as DATE) AND id_Funcionario = $idfuncionario";

$stmt = sqlsrv_query($conn, $sql);
if( $stmt === false) {
    die( print_r( sqlsrv_errors(), true) );
}



echo "<script>alert('Cancelamento realizado com sucesso!'); window.location.href='http://localhost/WebBoot/menu.html';</script>";