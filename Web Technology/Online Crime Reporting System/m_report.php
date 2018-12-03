<?php
include_once 'config_db.php';
?>
<!DOCTYPE html>
<head>
    <title>Motijheel</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
	<script type="text/javascript" src="report.js"></script>
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
	<form method="post" action="m_report.php">
	    <h1 style="color:green" "align=center">We will contact with you view mail or phone as soon as possible(max 3 days).</h1>

		<br/>
		<br/>
	    <table width="30%%" border="0" align="center">
        
		
		<td>Report Type :<td><select name="report_type" class="ed">
            <option>General Diary(GD)</option>
			<option>First Information Report(FIR)</option>
			<option>Others</option>
        </select></td></td>
	    </tr>
		<tr>
	        <td>Complainant:</td>
            <td><input type="text" name="complainant" id="complainant" class="ed" onblur="Complainant()"/></td>
	        <td>
		        <div id="mcomplainant" width="400"></div>
	        </td>
        </tr>
        <tr>
	        <td>Complainant Address</td>
	        <td><select type="text" name="caddress" id="caddress" class="ed" onblur="Caddress()" />
			        <option>Uttara, Dhaka</option>
				    <option>Banani Dhaka</option>
				    <option>Farmgate, Dhaka</option>
				    <option>Dhanmondi, Dhaka</option>
				    <option>Motijheel, Dhaka</option>
				    <option>New Market, Dhaka</option>
				    <option>Azimpur, Dhaka</option>
				    <option>New Market, Dhaka</option>
				    <option>Chawkbazar, Dhaka</option>
				    <option>Hazaribagh, Dhaka</option>
				    <option>Kotwali, Dhaka</option>
				    <option>Savar, Dhaka</option>
                </select>
			
			</td>
	        <td>
			    <div id="mcaddress"></div>
		    </td>
	    </tr>	
		<tr>
	        <td>Complainant Email:</td>
	        <td><input type="text" name="cemail" id="cemail"  class="ed" onblur="Cemail()" /></td>
	        <td>
			    <div id="mcemail"></div>
		    </td>
	    </tr>	
	    <tr>
	        <td>Complainant Phone(+88):</td>
	        <td><input type="text" name="cphone" id="cphone"  class="ed"onblur="Cphone()" /></td>
	        <td>
			    <div id="mcphone"></div>
		    </td>
	    </tr>	
	    <tr>
		    <td>Suspects/Criminals:</td>
	        <td><input type="text" name="suspect" id="suspect" class="ed" onblur="Suspect()" /></td>
	        <td>
			    <div id="msuspect"></div>
		    </td>
	    </tr>
		<tr>
		    <td>No. of Suspects/Criminals:</td>
	        <td><input type="text" name="nsuspect" id="nsuspect"  class="ed" onblur="Nsuspect()" /></td>
	        <td>
			    <div id="mnsuspect"></div>
		    </td>
	    </tr>
		<tr>
	        <td>Suspects Address</td>
	        <td><select type="text" name="saddress" id="saddress" class="ed" onblur="Saddress()" />
			       
					<option>Uttara, Dhaka</option>
				    <option>Banani Dhaka</option>
				    <option>Farmgate, Dhaka</option>
				    <option>Dhanmondi, Dhaka</option>
				    <option>Motijheel, Dhaka</option>
				    <option>New Market, Dhaka</option>
				    <option>Azimpur, Dhaka</option>
				    <option>New Market, Dhaka</option>
				    <option>Chawkbazar, Dhaka</option>
				    <option>Hazaribagh, Dhaka</option>
				    <option>Kotwali, Dhaka</option>
				    <option>Savar, Dhaka</option>
				</select>	
			
			
			</td>
	        <td>
			    <div id="msaddress"></div>
		    </td>
	    </tr>
	   <tr>
		    <td>Type of Arms Being Carried:</td>
	        <td><input type="text" name="arms" id="arms" class="ed" onblur="Arms()" /></td>
	        <td>
			    <div id="marms"></div>
		    </td>
	    </tr>
		<tr>
	        <td>Suspect Phone(+88)(if known):</td>
	        <td><input type="text" name="sphone" id="sphone" class="ed" onblur="Sphone()" /></td>
	        <td>
			    <div id="msphone"></div>
		    </td>
	    </tr>
		
		<tr>
	        
	        <td>Details:</td>
	        <td><textarea name="details" cols="20" rows="5" align="center" id="details" class="ed" placeholder="Write Details(Specific with Location)......" onblur="Details()"></textarea></td>
			
			<td>
			    <div id="mdetails"></div>
		    </td>
	    </tr>
		
	  <tr>
	  <td></td>
      <td><input type="submit" value="Sent" name="Submit" id="button1"/></td>
	  </tr>
	  </table>
	  
    </form>
</body>
</html>
<?php

     $host="localhost";
	 $user="root";
	 $pass="";
	 $db="ocfs";
	 
	 mysql_connect($host, $user, $pass) or die("Unable to connect DataBase");
	 mysql_select_db($db)or die("Unable to select DataBase");
	 
	 if(isset($_POST['Submit'])) {	
	       //$thana=$_POST['thana'];
		   $report_type = $_POST['report_type'];
	       $complainant=$_POST['complainant'];
		   $caddress=$_POST['caddress'];
		   $cemail=$_POST['cemail'];
		   $cphone=$_POST['cphone'];
		   $suspect=$_POST['suspect'];
		   $nsuspect=$_POST['nsuspect'];
		   $saddress = $_POST['saddress'];
	       $arms=$_POST['arms'];
		   $sphone=$_POST['sphone'];
		   $details=$_POST['details'];
		   
		 
		$query = mysql_query("INSERT INTO motijheel(report_type,complainant,caddress,cemail,cphone,suspect,nsuspect,saddress,arms,sphone,details) VALUES('$report_type','$complainant','$caddress','$cemail','$cphone','$suspect','$nsuspect','$saddress','$arms','$sphone','$details')");
		
		echo "<p align='center'> <font color=#00CCFF size='6pt'>You Report has been Successfully Sent.</font> </p>";
		
	
  }

?>
		