<?php
include_once 'config_db.php';
?>
<!DOCTYPE html>
<head>
    <title>Missing</title>
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
	<h1 style="color:Red" >List of Missing people:</h1>
    <br />
	<p style="font-size:20px">Please Sent an Instant <a href="mailto: phkoumas@gmail.com">mail</a> or make a <a href="tel:+8801746802875">Call</a>  to our Support line if you find any of them in anywhere. Thank You.
    <br />
	<br />
	<br />
</body>
</html>
<?php
include('config_db.php');
$result = mysql_query("SELECT * FROM missing");
while($row = mysql_fetch_array($result))
{
echo '<div id="imagelist">';
echo '<p><img src="'.$row['location'].'"></p>';
echo '<p id="caption">'.$row['caption'].' </p>';
echo '</div>';
}