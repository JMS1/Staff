var factoryId = 'empfactory'

angular.module('app')
    .factory(factoryId, ['$http', empfactory]);

function empfactory($http) {
    //??
    var urlBase = '/test/Get';
    var empFactory = {};

    empFactory.getEmployees = function () {
        return $http.get(urlBase);
    }



    return empFactory;
}