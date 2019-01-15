<?php
include_once 'config_db.php';
?>
<!DOCTYPE html>
<head>
    <title>Dhanmondi</title>
	<link rel="stylesheet" type="text/css" href="styles.css">

</head>	
</head>
<body>
    <div id="header">
	<div id="top-header">
		<div id="police-logo">
			<h1><img src="http://localhost/ocfs/images/police.png" id="logo"></h1>
			<h2>Dahnmondi Police Station</h2>
		</div>
		<ul id="main-menu">
		    <li><a href="dhanmondi.php">Home</a></li>
			<li><a href="d_info.php">Info</a></li>
			<li><a href="d_report.php">Report</a></li>
			<li><a href="d_wanted_criminals.php">Wanted Criminal</a></li>
			<li><a href="d_missing_public.php">Missing Person</a></li>
		
	    </ul>
		


	    <div id="add-navigation">
			<a href="https://www.facebook.com/phkoumas"><img src="http://localhost/ocfs/images/facebook.png"></a>
			<a href="https://www.twitter.com"><img src="http://localhost/ocfs/images/twitter.png"></a>
			<a href="https://www.youtube.com"><img src="http://localhost/ocfs/images/youtube.png"></a>
		
			
		</div>
	</div>
		<div id="header-banner-wrap">
		    <div id="header-banner">
			    <h2><span>News & Archive</span></h2>
	
		    </div>
	    </div>
    </div>
        	
    <div id="body">
	    <br/>
		<br/>
		<table width="80%" align="center" border="1" cellspacing="0" cellpadding="8">
            
            <tr>
	            <td style="font-size:20px">Headlines</td>
                <td style="font-size:20px">View</td>
            </tr>
        <?php
	        $sql="SELECT * FROM news";
	        $result_set=mysql_query($sql);
	        while($row=mysql_fetch_array($result_set))
	   {
		?>
        <tr>
        
		    <td><?php echo $row['caption'] ?></td>
            <td><a href="uploads/<?php echo $row['file'] ?>" target="_blank">details</a></td>
        </tr>
        <?php
	    }
	    ?>
        </table>
    
    </div>
</body>
</html>