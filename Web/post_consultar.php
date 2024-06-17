<?php
include_once "./connect.php";

$nome = $_POST['nomeV'];
$acessorios = $_POST['acessoriosV'];
$bloco = $_POST['blocoV'];
$sala = $_POST['salaV'];
$data = $_POST['dataV'];
$hora = $_POST['horaV'];


$where = " WHERE 1=1";

$tableReturn = "<table class='formulario'>
                    <tr>
                        <th>Funcionário</th>
                        <th>Acessório</th>
                        <th>Bloco</th>
                        <th>Sala</th>
                        <th>Data</th>
                        <th>Hora</th>
                    </tr>";

if($nome != '')
    $where .= " AND nome_Funcionario like '%$nome%'";
if($acessorios != '')
    $where .= " AND i.id_Item = $acessorios";
if($bloco != '')
    $where .= " AND bloco = '$bloco'";
if($sala != '')
    $where .= " AND sala = '$sala'";
if($data != '')
    $where .= " AND CAST(data_Agendamento AS varchar(10)) = '$data'";
if($hora != '')
    $where .= " AND horario = '$hora'";

$sql = "SELECT f.nome_Funcionario AS nome, i.nome_Item, bloco, sala, CAST(data_Agendamento AS varchar(10)) AS data_Agendamento, horario
        FROM agenda_funcionario af
        INNER JOIN item_agenda ia ON ia.id_Agendamentos = af.id_Agendamentos
        INNER JOIN item i ON i.id_Item = ia.id_Item
        INNER JOIN funcionario f ON f.id_Funcionario = af.id_Funcionario
        $where";
//die("<pre>$sql");
$stmt = sqlsrv_query($conn, $sql);
if( $stmt === false) {
    die( print_r( sqlsrv_errors(), true) );
}

while( $row = sqlsrv_fetch_array( $stmt, SQLSRV_FETCH_ASSOC) ) {
    $tableReturn .= "<tr>
                        <td>{$row['nome']}</td>
                        <td>{$row['nome_Item']}</td>
                        <td>{$row['bloco']}</td>
                        <td>{$row['sala']}</td>
                        <td>{$row['data_Agendamento']}</td>
                        <td>{$row['horario']}</td>
                    </tr>";
}

$tableReturn .= "</table>";
echo $tableReturn;
?>

<style>
    <?php include 'post_consultar.css'; ?>
</style>