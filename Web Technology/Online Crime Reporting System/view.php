<?php
include_once 'config_db.php';
?>
<!DOCTYPE html>

<head>
<title>List of Uploaded Files</title>
<link rel="stylesheet" type="text/css" href="styles.css">
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
	<br/>
	<br/>
     <div id="body">
	    <table width="80%" align="center" border="1" cellspacing="0" cellpadding="8">
            <tr>
                <th colspan="4">Your Uploaded Files<p><a href="news.php">upload new files...</a><p></th>
            </tr>
            <tr>
	            <td style="font-size:20px">Headlines</td>
                <td style="font-size:20px">View</td>
				<td style="font-size:20px">Remove</td>
            </tr>
        <?php
	        $sql="SELECT * FROM news ORDER BY id ASC";
	        $result_set=mysql_query($sql);
	        while($row=mysql_fetch_array($result_set))
	   {
		?>
		
            <tr>
            <td><?php echo $row['caption'] ?></td>
            <td><a href="uploads/<?php echo $row['file'] ?>" target="_blank">details</a></td>
		    <?php
		    echo "<td><a href=\"remove_news.php?id=$row[id]\" onClick=\"return confirm('Are you sure you want to Remove?')\">x</a></td>";
		    ?>
            </tr>
		
        <?php
	    }
	    ?>
    </table>
    
    </div>
</body>
</html>