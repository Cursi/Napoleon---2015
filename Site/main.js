
		var q1 = document.getElementsByName("i1");
		var q2 = document.getElementsByName("i2");
		var q3 = document.getElementsByName("i3");
		var q4 = document.getElementsByName("i4");
		var q5 = document.getElementsByName("i5");
		var contor=0;
		//---------------------------------------
		
(function () {

	require.config({
		path: {
			text: './text',
			json: './json.js'
		}
	});

	require(['data.js'], function (data)
	{
		var r1,r2,r3,r4,r5;
		
		
		r1 = Math.floor((Math.random() * data.length ));

				r2 = Math.floor((Math.random() * data.length ));
				while (r2 == r1)
						r2 = Math.floor((Math.random() * data.length ));
						
				r3 = Math.floor((Math.random() * data.length ));
				while (r3 == r1 || r3 == r2)
						r3 = Math.floor((Math.random() * data.length ));
						
				r4 = Math.floor((Math.random() * data.length ));
				while (r4 == r1 || r4 == r2 || r4 == r3)
						r4 = Math.floor((Math.random() * data.length ));
						
				r5 = Math.floor((Math.random() * data.length ));
				while (r5 == r1 || r5 == r2 || r5 == r3 || r5 == r4)
						r5 = Math.floor((Math.random() * data.length ));
		
		//alert(data[0]["A"]);
		
		//rand = Math.floor((Math.random() * data.length ));
		//alert( q1[0].defaultValue );
		
		$("#i1").html(data[r1]["Q"]);
		$("#1a").html(data[r1]["A"]);
		$("#1b").html(data[r1]["B"]);
		$("#1c").html(data[r1]["C"]);
		$("#1d").html(data[r1]["D"]);
		q1[data[r1]["R"]].value = "c";
		//-----------------------------
		
		$("#i2").html(data[r2]["Q"]);
		$("#2a").html(data[r2]["A"]);
		$("#2b").html(data[r2]["B"]);
		$("#2c").html(data[r2]["C"]);
		$("#2d").html(data[r2]["D"]);
		q2[data[r2]["R"]].value = "c";
		//-----------------------------
		
		$("#i3").html(data[r3]["Q"]);
		$("#3a").html(data[r3]["A"]);
		$("#3b").html(data[r3]["B"]);
		$("#3c").html(data[r3]["C"]);
		$("#3d").html(data[r3]["D"]);
		q3[data[r3]["R"]].value = "c";
		//-----------------------------
		
		$("#i4").html(data[r4]["Q"]);
		$("#4a").html(data[r4]["A"]);
		$("#4b").html(data[r4]["B"]);
		$("#4c").html(data[r4]["C"]);
		$("#4d").html(data[r4]["D"]);
		q4[data[r4]["R"]].value = "c";
		//-----------------------------
		
		$("#i5").html(data[r5]["Q"]);
		$("#5a").html(data[r5]["A"]);
		$("#5b").html(data[r5]["B"]);
		$("#5c").html(data[r5]["C"]);
		$("#5d").html(data[r5]["D"]);
		q5[data[r5]["R"]].value = "c";
		//-----------------------------
		
		
			$("#mare").addClass("active");
		
	});
})();

		function adauga()
	{	
		if (q1[0].checked || q1[1].checked || q1[2].checked || q1[3].checked) contor++;
		if (q2[0].checked || q2[1].checked || q2[2].checked || q2[3].checked) contor++;
		if (q3[0].checked || q3[1].checked || q3[2].checked || q3[3].checked) contor++;
		if (q4[0].checked || q4[1].checked || q4[2].checked || q4[3].checked) contor++;
		if (q5[0].checked || q5[1].checked || q5[2].checked || q5[3].checked) contor++;

		if (contor == 5) $("#verifica").addClass("active");
			else contor = 0;
	}

		function final()
	{
			$("#mare").removeClass("active");
			$("#verifica").removeClass("active");
			$("#scor").addClass("active");
			
			var corecte = 0; var parcurge ;
			
			for (parcurge=0;parcurge<=q1.length -1;parcurge++)
			if (q1[parcurge].checked) if (q1[parcurge].value == "c") { corecte++; break; }
			
			for (parcurge=0;parcurge<=q2.length -1;parcurge++)
			if (q2[parcurge].checked) if (q2[parcurge].value == "c") { corecte++; break; }
			
			for (parcurge=0;parcurge<=q3.length -1;parcurge++)
			if (q3[parcurge].checked) if (q3[parcurge].value == "c") { corecte++; break; }
			
			for (parcurge=0;parcurge<=q4.length -1;parcurge++)
			if (q4[parcurge].checked) if (q4[parcurge].value == "c") { corecte++; break; }
			
			for (parcurge=0;parcurge<=q5.length -1;parcurge++)
			if (q5[parcurge].checked) if (q5[parcurge].value == "c") { corecte++; break; }
		
		if (corecte == 0) document.getElementById("ftext").innerHTML = "You have no right answer to any question." ;
		else
		document.getElementById("ftext").innerHTML = "You answered correctly " + corecte + "/5 questions." ;
	}
	
		function ref()
	{
			location.reload();
	}
