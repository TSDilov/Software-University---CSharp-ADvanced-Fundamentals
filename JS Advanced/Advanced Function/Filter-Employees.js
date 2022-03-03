function filterEmployes(data, criteria) {
    let arrayOfEmployees = JSON.parse(data);
    let criteriaArgs = criteria.split('-');
    let key = criteriaArgs[0];
    let value = criteriaArgs[1];
    let counter = 0;
    if (key === 'all') {
        console.log(arrayOfEmployees.map(e => `${counter++}. ${e.first_name} ${e.last_name} - ${e.email}`).join('\r\n'));
        return;
    }

    arrayOfEmployees = arrayOfEmployees.filter(e => e[key] === value);
    console.log(arrayOfEmployees.map(e => `${counter++}. ${e.first_name} ${e.last_name} - ${e.email}`).join('\r\n'));
}

filterEmployes(`[{
    "id": "1",
    "first_name": "Kaylee",
    "last_name": "Johnson",
    "email": "k0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Johnson",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  }, {
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }, {
    "id": "4",
    "first_name": "Evanne",
    "last_name": "Johnson",
    "email": "ev2@hostgator.com",
    "gender": "Male"
  }]`,
 'last_name-Johnson'
);