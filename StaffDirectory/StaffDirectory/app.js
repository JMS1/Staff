var appId = 'app'
var app = angular.module(appId, ['ngRoute']);

app.config(['$routeprovider', routeconfig]); 

function routeConfig($routeprovider) {
    $routeprovider.when('/', {
        controller: 'EController',
        templateUrl: 'Partials/TopBar.html'

    })
    .otherwise({ redirectTo: '/'});
};

