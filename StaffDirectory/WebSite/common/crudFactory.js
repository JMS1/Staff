angular.module('common.services')
    .factory('crudFactory', ['$http', 'employeeResource', 'appSettings', crudFactory])

function crudFactory($http, employeeResource, appSettings) {
    
    var crudFactory = {};


    crudFactory.deleteEmployee = function (id) {

        return $http.delete(appSettings.serverpath + '/api/test/' + id);
    }

    crudFactory.updateEmployee = function (emp) {

        return $http.put(appSettings.serverpath + '/api/test/' + emp.ID, emp);
    }

    crudFactory.addEmployee = function (newEmp) {

        return $http.post(appSettings.serverpath + '/api/test' , newEmp);
    }


    return crudFactory;
}

