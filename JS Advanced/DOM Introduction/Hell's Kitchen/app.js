function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);
   
   function onClick () {
      let textAreaRestaurants = JSON.parse(document.querySelector('#inputs textarea').value);
      let restaurantsArray = [];

      for (let restaurant of textAreaRestaurants) {
         let inputInfo = restaurant.split(' - ');
         let restaurantName = inputInfo[0];
         let employeesInfo = inputInfo[1].split(', ');
         let objectRestaurant = {};

         if (!restaurantsArray.some(r => r.name === restaurantName)) {
            objectRestaurant.name = restaurantName;
            objectRestaurant.employees = new Array();
            restaurantsArray.push(objectRestaurant);
         }else{
            objectRestaurant = restaurantsArray.find(r => r.name === restaurantName);
         } 

         for (let employee of employeesInfo) {
            let objectEmployee = {};
            let employeeInfo = employee.split(' ');
            let employeeName = employeeInfo[0];
            let employeeSalary = Number(employeeInfo[1]);
            objectEmployee.name = employeeName;
            objectEmployee.salary = employeeSalary;
            objectRestaurant.employees.push(objectEmployee);
         }

         let sumSalary = objectRestaurant.employees.reduce((a, b) => a + b.salary, 0);
         objectRestaurant.averageSalary = (sumSalary / objectRestaurant.employees.length) || 0;
      }

      restaurantsArray = restaurantsArray.sort((a, b) => b.averageSalary - a.averageSalary);
      let bestRestaurant = restaurantsArray[0];
      bestRestaurant.employees = bestRestaurant.employees.sort((a, b) => b.salary - a.salary);
      let bestSalary = bestRestaurant.employees[0].salary;
      document.querySelector('#bestRestaurant p').textContent = `Name: ${bestRestaurant.name} Average Salary: ${bestRestaurant.averageSalary.toFixed(2)} Best Salary: ${bestSalary.toFixed(2)}`;
      
      for (let worker of bestRestaurant.employees) {
         document.querySelector('#workers p').textContent += `Name: ${worker.name} With Salary: ${worker.salary} `;
      }
   }  
}