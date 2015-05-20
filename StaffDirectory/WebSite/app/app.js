//var appId = 'app'
//var app = angular.module(appId, ['ngRoute']);

//app.config(['$routeprovider', routeconfig]); 

//function routeConfig($routeprovider) {

//    $routeprovider.when('/', {
//        controller: 'EController',
//        templateUrl: 'Partials/TopBar.html'

//    })
//    .otherwise({ redirectTo: '/'});
//};

var appId = 'app'
var app = angular.module(appId, ['ngRoute', 'common.services', 'ui.bootstrap']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.otherwise({ redirectTo: '/' });


}])

