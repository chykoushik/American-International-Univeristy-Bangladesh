<?php

include_once("config_db.php");

if(isset($_POST['update']))
{	
	$username = $_POST['username'];
	
	$sp=$_POST['sp'];
    $addl_sp=$_POST['addl_sp'];
    $s_asp=$_POST['s_asp'];
    $asp=$_POST['asp'];
    $inspector = $_POST['inspector'];
	$sub_inspector=$_POST['sub_inspector'];
	$constable=$_POST['constable'];	
	
	$query = mysql_query("UPDATE create_stations SET sp='$sp', addl_sp='$addl_sp', s_asp='$s_asp', asp='$asp', inspector='$inspector', sub_inspector='$sub_inspector', constable='$constable' WHERE username=$username");
	header("Location: reg_stations.php");
	}
?>
<?php
    
    $username = $_GET['username'];

    $query = mysql_query("SELECT * FROM create_stations WHERE username=$username");
    while($res = mysql_fetch_array($query)){
        $sp=$res['sp'];
		$addl_sp=$res['addl_sp'];
		$s_asp=$res['s_asp'];
		$asp=$res['asp'];
		$inspector =$res['inspector'];
	    $sub_inspector=$res['sub_inspector'];
		$constable=$res['constable'];
}
	
?>
<html>
<head>	
	<title>Update </title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>

<body>
	<div id="header">
	    <div id="top-header">
		    <div id="police-logo">
			    <h1><img src="http://localhost/ocfs/images/police.png" id="logo"></h1>
			    <h2>Bangladesh Police</h2>
		    </div>
		    <ul id="main-menu">
			    <li><a href="admin.php">Create Station</a></li>
			    <li><a href="reg_stations.php">List of Stations </a></li>
			    <li><a href="civilian.php">Civilian  </a></li>
			    <li><a href="index.html">Logout</a></li>
	        </ul>
		</div>
	
	<h1 style="color: RED" align="center">Update</h1>
	<form name="form1" method="post" action="update.php">
		<table width="65%" border="1" cellspacing='0' align="center">
			
			<tr> 
				<td>SP</td>
				<td><input type="text" name="sp" placeholder="Name" value=<?php echo $sp;?>></td>
			</tr>
			<tr> 
				<td>Addl SP</td>
				<td><input type="text" name="addl_sp" placeholder="Name" value=<?php echo $addl_sp;?>></td>
			</tr>
			<tr>
			<tr> 
				<td>Senior ASP</td>
				<td><input type="text" name="s_asp" placeholder="Name" value=<?php echo $s_asp;?>></td>
			</tr>
			<tr> 
				<td>ASP</td>
				<td><input type="text" name="asp" placeholder="Name" value=<?php echo $asp;?>></td>
			</tr>
			<tr> 
				<td>No. of Inspector</td>
				<td><input type="text" name="inspector" placeholder="total" value=<?php echo $inspector;?>></td>
			</tr>
			<tr> 
				<td>No. of Sub Inspector</td>
				<td><input type="text" name="sub_inspector" placeholder="total" value=<?php echo $sub_inspector;?>></td>
			</tr>
			<tr> 
				<td>No. of Constable</td>
				<td><input type="text" name="constable" placeholder="total" value=<?php echo $constable;?>></td>
			</tr>
			<tr>
				<td><input type="hidden" name="username" value=<?php echo $_GET['username'];?>></td>
				<td><input type="submit" name="update" value="Update"></td>
			</tr>
		</table>
	</form>
</body>
</html>
