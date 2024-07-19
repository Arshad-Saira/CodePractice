// $(document).ready(async function getData() {
  // const url = "https://jsonplaceholder.typicode.com/posts";
  // try {
    // const response = await fetch(url);
    // if (!response.ok) {
      // throw new Error(`Response status: ${response.status}`);
    // }
	
	
    // const json = await response.json();
	// let output = "<tr>";
    // for (let i = 0; i < 10; i++) {
    // output += "<td>" + json[i].title + "</td>" + 
	// "<td>" + json[i].id + "</td>" +
	// "<td>" + json[i].userId + "</td>" + "</tr>"; 
    // }
	
    // $("table").append(output);
	// $(".load a").text("Load more");
	// console.log(output);
    // // console.log(json);
  // } catch (error) {
    // console.error(error.message);
  // }
// })
// $(document).ready(function(){
	// var rows = 20, rowsStart = 10;
	
		// rows +=10;
		// $(".load").click(async function getData(event) {
			// event.preventDefault();
			// const url = "https://jsonplaceholder.typicode.com/posts";
			// try {
			// const response = await fetch(url);
			// if (!response.ok) {
			// throw new Error(`Response status: ${response.status}`);
			// }
	
	
			// const json = await response.json();
			// let output = "<tr>";
			// for (let i = rowsStart; i < rows; i++) {
			// output += "<td>" + json[i].title + "</td>" + 
				// "<td>" + json[i].id + "</td>" +
				// "<td>" + json[i].userId + "</td>" + "</tr>"; 
			// }
	
			// $("table").append(output);
			// $(".load a").text("Load more");
			// rowsStart+=10;
			// console.log(output);
			// } catch (error) {
			// console.error(error.message);
			// }
		// })
	
// })
//initially books display
var rowsStart = 0; rowsEnd = 10;
$(document).ready(function() {
	$("#books").ready(function() {
	$.ajax({
		url: "data.json",
		method: "GET",
		success: function(data) {
		
		console.log("in");
			let output = "<tr>";
				for (let i =0; i < 10; i++) {
				output += "<td id=\"title\">" + data[i].title + "</td>" + 
				"<td>" + data[i].id + "</td>" +
				"<td>" + data[i].userId + "</td>" + "</tr>"; 
				}	
				output += "</tr>";
				$("table").append(output);
				console.log(output);
				$(".load a").text("Load more..");
			}
		});
	});
});

//Load more
var loadFrom = 10 , loadTo = rowsEnd;
$(document).ready(function() {
	$(".load").click(function(event) {
	event.preventDefault();
	$.ajax({
		url: "data.json",
		method: "GET",
		success: function(data) {
		console.log("win", loadTo);
			let output = "<tr>";
				for (let i = loadFrom; i < loadTo; i++) {
				output += "<td id=\"title\">" + data[i].title + "</td>" + 
				"<td>" + data[i].id + "</td>" +
				"<td>" + data[i].userId + "</td>" + "</tr>"; 
				}	
				output += "</tr>";
				$("table").append(output);
			}
		});
		loadFrom = loadTo;
		loadTo+=10;
		if(loadTo > 100)
		{
			$(".load a").text("No more records");
		}
	});
		
});

//search books
$(document).ready(function(){
  $(".searchInput").on("keyup", function() {
	//console.log("i am in");
    var value = $(this).val().toLowerCase();
	//console.log(value);
    // var input, filter, table, tr, td, i, txtValue;
	  // input = document.getElementById("myInput");
	  // filter = input.value.toUpperCase();
	  // table = document.getElementById("myTable");
	  // tr = table.getElementsByTagName("tr");
	  
	$('table tbody tr').each(function(index, item) {
	console.log("in");
    var title = $(this).find("#title").text();
	console.log(title); 
	if(title.toLowerCase().indexOf(value) > -1){
		//$('table tr').show("");
		console.log($('table tr').show(""));
		console.log("hello", item);
		return $(item).show("");
  } 
	else {
		console.log($('table tr').hide());
		console.log("hello23" , item);
		//$('table tr').removeAttr("style").hide();;
		return $(item).hide();
	}
	});
	  
		
	  // Loop through all table rows, and hide those who don't match the search query
	  // for (i = 0; i < tr.length; i++) {
		// td = tr[i].getElementsByTagName("td")[0];
		// if (td) {
		  // txtValue = td.textContent || td.innerText;
		  // if (txtValue.toUpperCase().indexOf(filter) > -1) {
			// tr[i].style.display = "";
		  // } else {
			// tr[i].style.display = "none";
		  // }
		// }
	  // }
  });
});





// $(document).ready(function(){
  // $(".searchInput").on("keyup", function() {
    // var value = $(this).val().toLowerCase();
    // var response = $(data).filter(function(i, n)
            // {
                // return   n.name !== value;
            // });

            // $.each(response, function(i) {
                // alert(response[i].commentText);
            // });
  // });
// });



