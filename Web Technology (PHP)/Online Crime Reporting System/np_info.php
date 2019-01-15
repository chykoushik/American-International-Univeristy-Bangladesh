<?php
     include('config_db.php');
     $result = mysql_query("SELECT * FROM create_stations WHERE address='NewMarket' ORDER BY username DESC");
?>
<!DOCTYPE html>
<head>
    <title>Info</title>
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
		<h1 style="color: GREEN">Informations</h1>
	    
            
		        
<?php 
	while($res = mysql_fetch_array($result)) { 		
		echo "<table width='100%' align='center' border='1' cellspacing='0'>";
		echo "<tr bgcolor='RED'>";
		echo "<tr>";
		echo "<td>Name</td>";
		echo "<td>".$res['name']."</td>";
		echo "</tr>";
		echo "<tr>";
		echo "<td>Area</td>";
		echo "<td>".$res['area']."</td>";	
		echo "</tr>";
		echo "<tr>";
		echo "<td>Superintendent Police(SP)</td>";
		echo "<td>".$res['sp']."</td>";
		echo "</tr>";
		echo "<tr>";
		echo "<td>Additional Superintendent Police(Addl. SP)</td>";
		echo "<td>".$res['addl_sp']."</td>";
		echo "</tr>";
		echo "<tr>";
		echo "<td>Senior Assistant Superintendent Police</td>";
		echo "<td>".$res['s_asp']."</td>";
		echo "</tr>";
		echo "<tr>";
		echo "<td>Assistant Superintendent Police</td>";
		echo "<td>".$res['asp']."</td>";
        echo "</tr>";	
        echo "<tr>";
		echo "<td>No. of Inspector</td>";
		echo "<td>".$res['inspector']."</td>";
		echo "</tr>";
		echo "<tr>";
		echo "<td>No. of Sub Inspector</td>";
		echo "<td>".$res['sub_inspector']."</td>";
		echo "</tr>";
		echo "<tr>";
	    echo "<td>No. of Constable</td>";	
		echo "<td>".$res['constable']."</td>";
		echo "</tr>";
		echo "</tr>";
		echo "</table>";
	}
	?>
	
	

		
</body>
<html>		