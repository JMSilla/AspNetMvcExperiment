$(function() {
	$("#completeList").click(function() {
		$.post("/Home/Elements", function(data) {
			$("#titleList").text(data.title);
			$.each(data.elementList, function(index, value) {
				$("#elementList").append("<li>" + value + "</li>");
			});
		});
	});
}
);
