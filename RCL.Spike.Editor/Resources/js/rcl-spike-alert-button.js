$(function () {
	$('.rcl-spike-alert-button').on('click', function () {
		var controlId = $(this).data("control-id");
		alert(controlId);
	});
});

