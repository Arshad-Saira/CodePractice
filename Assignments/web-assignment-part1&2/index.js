
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
	
    var value = $(this).val().toLowerCase();
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
  });
});
