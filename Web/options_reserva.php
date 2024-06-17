<?php
include_once "./connect.php";

$sql = "SELECT * FROM item";
$stmt = sqlsrv_query($conn, $sql);
if( $stmt === false) {
    die( print_r( sqlsrv_errors(), true) );
}

while( $row = sqlsrv_fetch_array( $stmt, SQLSRV_FETCH_ASSOC) ) {
    echo '<option value="' . $row['id_Item'] . '">' . $row['nome_Item'] . '</option>';
}

?>