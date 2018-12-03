<?php
     include('config_db.php');
     $result = mysql_query("SELECT * FROM create_stations ORDER BY username DESC");
?>
<!DOCTYPE html>
<head>
    <title>List Of Stations</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>	
</head>
<body>
  
	<div id="top-header">
		<div id="police-logo">
			<h1><img src="http://localhost/ocfs/images/police.png" id="logo"></h1>
			<h2>Bangladesh Police</h2>
		</div>
		<ul id="main-menu">
			<li><a href="admin.html">Admin Home</a></li>
			<li><a href="reg_stations.php">List of Stations </a></li>
			<li><a href="index.html">Logout</a></li>
	    </ul>
		</div>
		<h1 style="color: RED">List of Registered Police Stations(Details)</h1>
	    <table width='100%' border='1' cellspacing='0'>
            <tr bgcolor='RED'>
		        <td>Station Name</td>
		        <td>Address</td>
		        <td>Area</td>
		        <td>SP</td>
		        <td>Addl SP</td>
		        <td>Senior ASP</td>
		        <td>ASP</td>
		        <td>No. of Inspector</td>
		        <td>No. of Sub Inspector</td>
		        <td>No. of Constable</td>
		        <td>Station ID</td>
				<td>Update</td>
		        <td>Remove</td>
			</tr>
	<?php 
	while($res = mysql_fetch_array($result)) { 		
		echo "<tr>";
		echo "<td>".$res['name']."</td>";
		echo "<td>".$res['address']."</td>";
		echo "<td>".$res['area']."</td>";	
		echo "<td>".$res['sp']."</td>";
		echo "<td>".$res['addl_sp']."</td>";
		echo "<td>".$res['s_asp']."</td>";
		echo "<td>".$res['asp']."</td>";	
		echo "<td>".$res['inspector']."</td>";
		echo "<td>".$res['sub_inspector']."</td>";
		echo "<td>".$res['constable']."</td>";
		echo "<td>".$res['username']."</td>";	
		echo "<td><a href=\"update.php?username=$res[username]\">+</a>"; 
		echo "<td><a href=\"remove.php?username=$res[username]\" onClick=\"return confirm('Are you sure you want to Remove?')\">x</a></td>";		
	}
	?>
	
	</table>

		
</body>
<html>		