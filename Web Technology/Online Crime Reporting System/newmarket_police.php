<?php
     include('config_db.php');
     $result = mysql_query("SELECT * FROM newmarket ORDER BY report_type DESC");
?>
<!DOCTYPE html>
<head>
    <title>Motijheel</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>	
</head>
<body>
    
	<div id="top-header">
		<div id="police-logo">
			<h1><img src="http://localhost/ocfs/images/police.png" id="logo"></h1>
			<h2>NewMarket Police Station</h2>
		</div>
		<ul id="main-menu">
			<li><a href="newmarket_police.php">Report</a></li>
			<li><a href="np_info.php">Info</a></li>
			<li><a href="index.html">Logout</a></li>
	    </ul>
		</div>
	
		<h1 style="color: green" "font-size:20px">List of Reports(Details)</h1>
		<br />
		<br/>
	    <table width='100%' border='1' cellspacing='0'>
            <tr bgcolor='RED'>
		        <td>Report Type</td>
		        <td>Complainant</td>
		        <td>Com_Address</td>
		        <td>Com_Phone</td>
		        <td>Com_Email</td>
		        <td>Suspect/Criminal</td>
		        <td>Sus_Address</td>
		        <td>No. of Sub Inspector</td>
		        <td>Carried Arms</td>
		        <td>Sus_Phone(if known)</td>
				<td>Details</td>
		        
			</tr>
	<?php 
	while($res = mysql_fetch_array($result)) { 		
		echo "<tr>";
		echo "<td>".$res['report_type']."</td>";
		echo "<td>".$res['complainant']."</td>";
		echo "<td>".$res['caddress']."</td>";	
		echo "<td>".$res['cphone']."</td>";
		echo "<td>".$res['cemail']."</td>";
		echo "<td>".$res['suspect']."</td>";
		echo "<td>".$res['saddress']."</td>";	
		echo "<td>".$res['nsuspect']."</td>";
		echo "<td>".$res['arms']."</td>";
		echo "<td>".$res['sphone']."</td>";
		echo "<td>".$res['details']."</td>";	
				
	}
	?>
	</table>

    
</body>
</html>