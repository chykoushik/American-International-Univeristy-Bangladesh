<?php
     include('config_db.php');
     $result = mysql_query("SELECT * FROM create_stations WHERE address='Motijheel'ORDER BY username DESC");
?>
<!DOCTYPE html>
<head>
    <title>Info</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
	
</head>	
</head>
<body>
    <div id="header">
	<div id="top-header">
		<div id="police-logo">
			<h1><img src="http://localhost/ocfs/images/police.png" id="logo"></h1>
			<h2>Motijheel Police Station</h2>
		</div>
		<ul id="main-menu">
		    <li><a href="motijheel.php">Home</a></li>
			<li><a href="m_info.php">Info</a></li>
			<li><a href="m_report.php">Report</a></li>
			<li><a href="m_wanted_criminals.php">Wanted Criminal</a></li>
			<li><a href="m_missing_public.php">Missing Person</a></li>
		
	    </ul>
		


	    <div id="add-navigation">
			<a href="https://www.facebook.com/phkoumas"><img src="http://localhost/ocfs/images/facebook.png"></a>
			<a href="https://www.twitter.com"><img src="http://localhost/ocfs/images/twitter.png"></a>
			<a href="https://www.youtube.com"><img src="http://localhost/ocfs/images/youtube.png"></a>
		
			
		</div>
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