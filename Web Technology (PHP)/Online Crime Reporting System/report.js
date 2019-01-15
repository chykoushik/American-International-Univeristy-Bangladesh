function Complainant()
{
	var complainant = document.getElementById("complainant").value;

	if(complainant.length==0)
	{
		document.getElementById("mcomplainant").style.color="green";
		document.getElementById("mcomplainant").innerHTML ="Can Not No Empty";
	}
	else if(complainant.length>0 && complainant.length<4)
	{
		document.getElementById("mcomplainant").style.color="green";
		document.getElementById("mcomplainant").innerHTML ="At least 6 character";
	}
	else
	{
		document.getElementById("mcomplainant").style.color="green";
		document.getElementById("mcomplainant").innerHTML = "Ok";
	}

}
function Caddress()
{
    var caddress=document.getElementById("caddress").value;
	if(caddress.length==0)
	{
		document.getElementById("mcaddress").style.color="green";
		document.getElementById("mcaddress").innerHTML ="Can Not No Empty";
	}else
	{
		document.getElementById("mcaddress").style.color="green";
		document.getElementById("mcaddress").innerHTML = "Ok";
	}
}
function Cphone()
{
	var cphone = document.getElementById("cphone").value;

	if(cphone.length==0)
	{
		document.getElementById("mcphone").style.color="green";
		document.getElementById("mcphone").innerHTML ="Can Not Be Empty";
	}
	else if(cphone.length>10 && cphone.length<12)
	{
		document.getElementById("mcphone").style.color="green";
		document.getElementById("mcphone").innerHTML ="Ok";
	}else
	{
		document.getElementById("mcphone").style.color="green";
		document.getElementById("mcphone").innerHTML = "Try A Valid Number";
	}

}
function Cemail() {
    var cemail = document.getElementById("cemail").value;
	
	
    var reg = /^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$/;
     if(cemail.length==0)
	{
		document.getElementById("mcemail").style.color="green";
		document.getElementById("mcemail").innerHTML ="Can Not Be Empty";
	}
	 else if (reg.test(cemail)){
        document.getElementById("mcemail").style.color="green";
		document.getElementById("mcemail").innerHTML ="Ok";
    }
    else{
       document.getElementById("mcemail").style.color="green";
	   document.getElementById("mcemail").innerHTML ="Try A Valid Email";
    }
 }
function Suspect()
{
	var suspect = document.getElementById("suspect").value;

	if(suspect.length==0)
	{
		document.getElementById("msuspect").style.color="green";
		document.getElementById("msuspect").innerHTML ="Can Not No Empty";
	}
	else if(complainant.length>0 && complainant.length<4)
	{
		document.getElementById("msuspect").style.color="green";
		document.getElementById("msuspect").innerHTML ="At least 6 character";
	}
	else
	{
		document.getElementById("msuspect").style.color="green";
		document.getElementById("msuspect").innerHTML = "Ok";
	}


}
function Nsuspect()
{
	var nsuspect = document.getElementById("nsuspect").value;

	if(nsuspect.length==0)
	{
		document.getElementById("mnsuspect").style.color="green";
		document.getElementById("mnsuspect").innerHTML ="Can Not Be Empty";
	}else
	{
		document.getElementById("mnsuspect").style.color="green";
		document.getElementById("mnsuspect").innerHTML = "Ok";
	}

}
function Saddress()
{
    var saddress=document.getElementById("saddress").value;
	if(saddress.length==0)
	{
		document.getElementById("msaddress").style.color="green";
		document.getElementById("msaddress").innerHTML ="Ok";
	}else
	{
		document.getElementById("msaddress").style.color="green";
		document.getElementById("msaddress").innerHTML = "Ok";
	}
}
function Arms()
{
    var arms=document.getElementById("arms").value;
	if(arms.length==0)
	{
		document.getElementById("marms").style.color="green";
		document.getElementById("marms").innerHTML ="Can Not Be Empty";
	}else
	{
		document.getElementById("marms").style.color="green";
		document.getElementById("marms").innerHTML = "Ok";
	}
}
function Sphone()
{
	var sphone = document.getElementById("sphone").value;

	if(sphone.length==0)
	{
		document.getElementById("msphone").style.color="green";
		document.getElementById("msphone").innerHTML ="Can Not Be Empty";
	}
	else if(sphone.length>10 && sphone.length<12)
	{
		document.getElementById("msphone").style.color="green";
		document.getElementById("msphone").innerHTML ="Ok";
	}else
	{
		document.getElementById("msphone").style.color="green";
		document.getElementById("msphone").innerHTML = "Try A Valid Number";
	}

}
function Details()
{
    var details=document.getElementById("details").value;
	if(details.length==0)
	{
		document.getElementById("mdetails").style.color="green";
		document.getElementById("mdetails").innerHTML ="Can Not No Empty";
	}else
	{
		document.getElementById("mdetails").style.color="green";
		document.getElementById("mdetails").innerHTML = "Ok";
	}
} 