angular-bg-image
==============

bg-image is a directive to use CSS background-image attribute on elements.


## Install

### Bower
```
bower install angular-bg-image --save
```

### CDN
```html
<script src="https://cdn.rawgit.com/matheusrufca/angular-bg-image/master/dist/angular-bg-image.js"></script>
```

## Getting started

Include both **angular-bg-image.js** in your application.

```html
<script src="bower_components/angular-bg-image/dist/angular-bg-image.js"></script>
```

Add the module `mr` as a dependency to your app module:

```js
angular.module('app', ['mr']);
```


## Usage

Use the directive like

###### HTML
```html
<div bg-image="model.pictureUrl" class="preview"></div>
```
or

```html
<div bg-image="{{getPictureUrl()}}" class="preview"></div>
```

###### Controller
```js
angular.module('app', ['mr'])
  .controller('DemoCtrl', function($scope){
    $scope.model {
      pictureUrl = 'http://i.imgur.com/xbiHEMe.jpg'
    };

    $scope.getPictureUrl = function(){
      return $scope.model.pictureUrl;
    };
  };
```

##### View demo on [Plunker](https://embed.plnkr.co/hLwfPh9M1BOpGDDibnhA/)

## License

Licensed under MIT.
