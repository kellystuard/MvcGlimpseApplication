(function ($) {

	$('a[data-glimpse-trace=show]').on('click', function (e) {
		$('.glimpse-icon').click();
		$('li[data-glimpsekey=glimpse_trace]').click();
		e.preventDefault();
	});

}(jQuery));
