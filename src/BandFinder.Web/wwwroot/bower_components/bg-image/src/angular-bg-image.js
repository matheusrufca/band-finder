(function(angular) {
	if (!angular) {
		console.error('Angular is not defined.');
		return;
	}

	angular
		.module('mr', [])
		.directive('bgImage',
			function() {
				function applyBackgroundImage(element, url) {
					if (!element || !url) {
						return;
					}
					element.css({ 'background-image': ['url(', url, ')'].join('') });
				};

				return {
					restrict: 'A',
					link: function($scope, element, attrs) {
						if (!attrs.bgImage) {
							return;
						}

						if ($scope.hasOwnProperty(attrs.bgImage)) {
							$scope.$watch(attrs.bgImage,
								function(newValue, oldValue) {
									//if (newValue == oldValue) { return; }
									if (!newValue) {
										return;
									}

									applyBackgroundImage(element, newValue);
								});
						} else {
							$scope.$watch(function() {
									return attrs.bgImage;
								},
								function(newValue, oldValue) {
									//if (newValue == oldValue) { return; }
									if (!newValue) {
										return;
									}

									applyBackgroundImage(element, newValue);
								});
						}
					}
				};
			})
})(window.angular);
