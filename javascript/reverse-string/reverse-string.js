export const reverseString = (str) => {
  const strArr = str.split('');
  const rts = [];

  strArr.forEach((char) => {
    rts.push(char);
  });

  return rts.join('');
};
