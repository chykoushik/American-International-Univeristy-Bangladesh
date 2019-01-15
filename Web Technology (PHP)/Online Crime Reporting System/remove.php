<?php
include('config_db.php');
 if (isset($_GET['username']) && is_numeric($_GET['username']))
 {
    $username = $_GET['username'];
    $result = mysql_query("DELETE FROM create_stations WHERE username=$username") or die(mysql_error()); 
    header("Location: reg_stations.php");
 }else{
 header("Location: reg_stations.php");
 }
?>