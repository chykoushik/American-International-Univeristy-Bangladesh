<head>
    <title>News</title>
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
	<p style="font-size:18px"> Uploaded Files <a href="view.php"> here</a></p>
	<br/>
	<br/>
	<form action="add2.php" method="post" enctype="multipart/form-data">
	Select File:<br/>
	<input type="file" name="file" class="ed" /><br/>
	
	Caption:<br/>
	<textarea name="caption" cols="35" rows="3" align="center" id="brnu" placeholder="Write Title/Caption........."></textarea><br/ >
	<button type="submit" name="submit" id="button1">upload</button><br/>
	</form>
    
    <br />
    <br/>

    <?php
	if(isset($_GET['success']))
	{
		?>
        <label>File Uploaded Successfully...  <a href="view.php">click here to view file.</a></label>
        <?php
	}
	else if(isset($_GET['fail']))
	{
		?>
        <label>Problem While File Uploading !</label>
        <?php
	}
	else
	{
		?>
        <label>Try to upload any files(PDF, DOC, TEXT,ZIP,etc...)</label>
        <?php
	}
	?>
</div>
</body>
</html>