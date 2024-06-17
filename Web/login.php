<?php
include_once "./connect.php";

$ra = $_POST['ra'];
$senha = $_POST['senha'];
$quantidade = 0;

$sql = "SELECT COUNT(*) AS QUANTIDADE FROM login WHERE ra = '$ra' AND senha = '$senha'";

$stmt = sqlsrv_query($conn, $sql);
if( $stmt === false) {
    die( print_r( sqlsrv_errors(), true) );
}
if( $row = sqlsrv_fetch($stmt) == false) {
    echo "Error in retrieving row.\n";
    die( print_r( sqlsrv_errors(), true));  
}

$quantidade = sqlsrv_get_field($stmt, 0);

if($quantidade > 0){
    echo "<script> window.location.href='http://localhost/WebBoot/menu.html'</script>";
} else {
    echo "<script> alert('LOGIN INVÁLIDO!'); window.location.href='http://localhost/WebBoot/';</script>";
}