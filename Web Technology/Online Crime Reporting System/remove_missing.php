<?php
include('config_db.php');
 if (isset($_GET['id']) && is_numeric($_GET['id']))
 {
    $id = $_GET['id'];
    $result = mysql_query("DELETE FROM missing WHERE id=$id") or die(mysql_error()); 
    header("Location: missing.php");
 }else{
 header("Location: missing.php");
 }
?>