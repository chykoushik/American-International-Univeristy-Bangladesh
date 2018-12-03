<!DOCTYPE html>
<head>
    <title>Wanted</title>
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
	<form action="add.php" method="post" enctype="multipart/form-data" name="addroom">
        Select Image: <br />
        <input type="file" name="image" class="ed"><br />
        Caption(Name and Birth Year)<br />
        <input name="caption" type="text" class="ed" id="brnu" />
        <br />
        <input type="submit" name="Submit" value="Upload" id="button1" />
     </form>
    <br />
    <br/>
    <br/>
    <h1 style="color:Red" >Most Wanted Criminals:</h1>
    <br />
    <br />
</body>
</html>
<?php
include('config_db.php');
$result = mysql_query("SELECT * FROM photos ORDER BY id DESC");
while($row = mysql_fetch_array($result))
{
echo '<div id="imagelist">';
echo '<p><img src="'.$row['location'].'"></p>';
echo '<p id="caption">'.$row['caption'].' </p>';
echo "<p><a href=\"remove_wanted.php?id=$row[id]\" onClick=\"return confirm('Are you sure you want to Remove?')\">x</a></p>";
echo '</div>';
}