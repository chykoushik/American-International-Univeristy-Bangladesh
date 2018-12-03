<?php
include('config_db.php');
 if (isset($_GET['id']) && is_numeric($_GET['id']))
 {
    $id = $_GET['id'];
    $result_set = mysql_query("DELETE FROM news WHERE id=$id") or die(mysql_error()); 
    header("Location: view.php");
 }else{
 header("Location: view.php");
 }
?>