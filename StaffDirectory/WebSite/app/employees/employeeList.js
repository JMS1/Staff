
    app.controller('employeeList',
    ['crudFactory', 'employeeResource', employeeList]);

function employeeList(crudFactory, employeeResource) {

    var vm = this;
   

    employeeResource.query(function (data) {
       
        vm.people = data;

    });

    vm.editMode = false;
    vm.status = '';
    vm.addMode = false;

    vm.deleteEmployee = function (id) {
        crudFactory.deleteEmployee(id)
        .success(function() {
            for (var i = 0; i < vm.people.length; i++) {
                var emp = vm.people[i];
                if (emp.ID === id){
                    vm.people.splice(i, 1);
                    break;
                }
            }
        })
        .error(function (error){
            vm.status = 'There was a problem:' + error.message;

        });
    }

    vm.toggleEdit = function () {
        vm.editMode = !vm.editMode;
    };

    vm.toggleAdd = function () {
        vm.addMode = !vm.addMode;
    };

    //vm.saveEmployee = function (id) {
    //    var emp;
    //    crudFactory.updateEmployee(emp)
    //    .success(function() {
    //        for(var i = 0; i < vm.people.length; i++) {
    //            var currEmp = vm.people[i];
    //            if (currEmp.ID === id) {
    //                emp = currEmp;
    //                break;
    //            }
    //        }
    //    })
      

    //    }

    vm.saveEmployee = function (id) {
        var emp;
        for (var i = 0; i < vm.people.length; i++) {
            var currEmp = vm.people[i];
            if (currEmp.ID === id) {
                emp = currEmp;
                break;
            }

        }

        crudFactory.updateEmployee(emp)
            .success(function () {
                vm.status = "Updated Employee";

            })
            .error(function () {
                vm.status = "Unable to update" + error.message;
            });

    }

    vm.addEmployee = function () {
        var emp = {
            "name": vm.name,
            "phoneNumber": vm.phoneNumber,
            "email": vm.email
        }
        //var newEmp = vm.person;
        crudFactory.addEmployee(emp)
        .success(function () {
            vm.status = "Created new Employee";
            vm.people.push(emp);
        })

        .error(function () {

            vm.status = "Unable to create" + error.message;
        })
    }

    }


