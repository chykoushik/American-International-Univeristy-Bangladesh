<!DOCTYPE html>
<head>
    <title>Login</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body style="margin: 0 auto">
<table width=100% height=100% border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
        <td><img src="images/police1.jpg" style="width:90%; height:5%"></td>
        <td valign="top">

            <table width="480" height="50" border="0" align="center"  cellpadding="13" cellspacing="13" > <br>
                <td align="right" valign="top"><a href="index.html"><img src="images/police.png" style="max-width:100%; max-height:100%"></a></td>
                <td align="center" valign="top"><big><p>Bangladesh Police</p><p>Online System</p></big> <p>-Discipline Security Progress </p></td>
                
                <form method="post" action="login.php">
					
                    <table width="25%%" border="0" align="center">
                        <h1 style="color: RED"" align="center">Login !! </h1>
						<tr>
	                        <td>Username:</td>
                            <td><input type="text" name="username" class="ed" /></td>
                        </tr>
	                    <tr>
	                        <td>Password:</td>
                        <td><input type="password" name="password" class="ed"/></td>
                        </tr>
	                    <tr>
	                        <td></td>
                            <td><input type="submit" value="Login" name="submit" id="button1"/></td>
	                    </tr>
	                </table>
    </tr>
            </table>
        </td>
        </tr>
</table>
</body>
</html>
<?php
session_start();
     $host="localhost";
	 $user="root";
	 $pass="";
	 $db="ocfs";
	 
	 mysql_connect($host, $user, $pass) or die("Unable to connect DataBase");
	 mysql_select_db($db)or die("Unable to select DataBase");

if(isset($_POST['submit'])){
	$username=$_POST['username'];
	$password=$_POST['password'];

	$sql  = "SELECT * FROM login WHERE username = '$username' && password = '$password'";
	$sql1  ="SELECT * FROM admin WHERE username = '$username' && password = '$password'";
	$sql2  ="SELECT * FROM create_stations WHERE username = '$username' && password = '$password'";
	$result = mysql_query($sql);
	$result1= mysql_query($sql1);
	$result2= mysql_query($sql2);
	$res = mysql_fetch_array($result);
	$res1 = mysql_fetch_array($result1);
	$res2 = mysql_fetch_array($result2);
	
	if($username = $res1['username'] && $password = $res1['password'])
	{
		header('Location: admin.html');
	}else if($username = $res2['username'] && $password = $res2['password'])
	{
		if($res2['address'] === 'Dhanmondi'){
			
			$_SESSION['username'] = $username;
			$_SESSION['address'] = $res2['address'];
	
			header('Location: dhanmondi_police.php');
			
		}else if($res2['address'] === 'Banani'){
			
			$_SESSION['username'] = $username;
			$_SESSION['address'] = $res2['address'];
	
			header('Location: banani_police.php');
		}else if($res2['address'] === 'NewMarket'){
			
			$_SESSION['username'] = $username;
			$_SESSION['address'] = $res2['address'];
	
			header('Location: newmarket_police.php');
		}
		else{

			$_SESSION['username'] = $username;
			$_SESSION['address'] = $res2['address'];
			header('Location: motijheel_police.php');	
		}
		
	}
	else{
		echo "<p align='center'> <font color=RED  size='6pt'>Invalid Username/Password</font> </p>";
	}
}
	?>
