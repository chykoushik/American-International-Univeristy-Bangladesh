<!DOCTYPE html>
<head>
    <title>Criminals</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
	<script type="text/javascript" src="public.js"></script>
</head>	
</head>
<body>
    <div id="header">
	<div id="top-header">
		<div id="police-logo">
			<h1><img src="http://localhost/ocfs/images/police.png" id="logo"></h1>
			<h2>NewMarket Police Station</h2>
		</div>
		<ul id="main-menu">
		    <li><a href="newmarket.php">Home</a></li>
			<li><a href="n_info.php">Info</a></li>
			<li><a href="n_report.php">Report</a></li>
			<li><a href="n_wanted_criminals.php">Wanted Criminal</a></li>
			<li><a href="n_missing_public.php">Missing Person</a></li>
		
	    </ul>
		


	    <div id="add-navigation">
			<a href="https://www.facebook.com/phkoumas"><img src="http://localhost/ocfs/images/facebook.png"></a>
			<a href="https://www.twitter.com"><img src="http://localhost/ocfs/images/twitter.png"></a>
			<a href="https://www.youtube.com"><img src="http://localhost/ocfs/images/youtube.png"></a>
		
			
		</div>
	</div>
		<h1 style="color:Red" >Most Wanted Criminals:</h1>
    <br />
	<p style="font-size:20px">Please Sent an Instant <a href="mailto: phkoumas@gmail.com">mail</a> or make a <a href="tel:+8801746802875">Call</a>  to our Support line if you see any of them in anywhere. Thank You.
    <br />
	<br />
	<br />
</body>
</html>
<?php
include('config_db.php');
$result = mysql_query("SELECT * FROM photos");
while($row = mysql_fetch_array($result))
{
echo '<div id="imagelist">';
echo '<p><img src="'.$row['location'].'"></p>';
echo '<p id="caption">'.$row['caption'].' </p>';
echo '</div>';
}
