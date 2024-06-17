<?php
//dados de conexao com banco de dados do sistema
//die("baababas");
$serverName = "KUHL"; 
$uid = "";   
$pwd = "";  
$databaseName = "gestao_de_acessorios"; 

$connectionInfo = array( "UID"=>$uid,                            
                         "PWD"=>$pwd,                            
                         "Database"=>$databaseName); 

/* Connect using SQL Server Authentication. */  
$conn = sqlsrv_connect( $serverName, $connectionInfo);
?>