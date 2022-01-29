function daysInAMonth(month, year) {
    let daysInMonth = 0;
    if ((month % 2 == 1 && month <= 7) || (month % 2 == 0 && month > 7)) {
        console.log(31);
    }else{
        if (month == 2 && year % 4 == 0) {
            console.log(29);
        }else if (month != 2) {
            console.log(30);
        } else {
            console.log(28);
        }
    }
}
daysInAMonth(4, 2000);