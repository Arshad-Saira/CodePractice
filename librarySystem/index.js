$(document).ready(async function getData() {
  const url = "https://jsonplaceholder.typicode.com/posts";
  try {
    const response = await fetch(url);
    if (!response.ok) {
      throw new Error(`Response status: ${response.status}`);
    }
	
	
    const json = await response.json();
	let output = "<tr>";
    for (let i = 0; i < 10; i++) {
    output += "<td>" + json[i].title + "</td>" + 
	"<td>" + json[i].id + "</td>" +
	"<td>" + json[i].userId + "</td>" + "</tr>"; 
    }
	
    $("table").append(output);
	$(".load a").text("Load more");
	console.log(output);
    // console.log(json);
  } catch (error) {
    console.error(error.message);
  }
})
$(document).ready(function(){
	var rows = 20, rowsStart = 10;
	while($(".load").click()){
		rows +=10;
		$(".load").click(async function getData(event) {
			event.preventDefault();
			const url = "https://jsonplaceholder.typicode.com/posts";
			try {
			const response = await fetch(url);
			if (!response.ok) {
			throw new Error(`Response status: ${response.status}`);
			}
	
	
			const json = await response.json();
			let output = "<tr>";
			for (let i = rowsStart; i < rows; i++) {
			output += "<td>" + json[i].title + "</td>" + 
				"<td>" + json[i].id + "</td>" +
				"<td>" + json[i].userId + "</td>" + "</tr>"; 
			}
	
			$("table").append(output);
			$(".load a").text("Load more");
			rowsStart+=10;
			console.log(output);
			} catch (error) {
			console.error(error.message);
			}
		})
	}
})
        // $(document).ready(function() {
            // $("#books").ready(function() {
                // $.ajax({
                    // url: "books.json",
                    // method: "GET",
                    // success: function(data) {
                        // let output = "<tr>";
                        // for (let i = 0; i < data.length; i++) {
                            // output += "<td>" + data[i].name + "</td>" + 
							// "<td>" + data[i].author + "</td>" +
							// "<td>" + data[i].price + "</td>" ;
                        // }
                        // output += "</tr>";
                        // $("table").appendChild(output);
                    // }
                // });
            // });
        // });

// $(document).ready(function(){
  // $(".searchInput").on("keyup", function() {
    // var value = $(this).val().toLowerCase();
    // var response = $(books).filter(function(i, n)
            // {
                // return   n.name !== value;
            // });

            // $.each(response, function(i) {
                // //alert(response[i].commentText);
            // });
  // });
// });



