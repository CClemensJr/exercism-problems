// on every year that is evenly divisible by 4
// except every year that is evenly divisible by 100
// unless the year is also evenly divisible by 400

export const isLeap = (year) => {
  if (year % 4 === 0 && year % 100 !== 0) {
    return true;
  } else if (year % 100 === 0 && year % 400 !== 0) {
    return false;
  } else if (year % 400 === 0) {
    return true;
  }

  return false;
};
