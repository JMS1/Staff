var serviceId = 'dataService';

angular.module('app')
    .service(serviceId, ['$http', dataService]);

function dataService($http) {
    var urlBase = '/test/Get';

    this.getEmployees = function () {
        return $http.get(urlBase);

    };


}