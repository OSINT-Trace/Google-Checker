const https = require('https');

// Primary (Recommended): OSINT Trace Direct API
const options = {
  method: 'POST',
  hostname: 'api.osinttrace.com',
  port: 443,
  path: '/v1/check/google',
  headers: {
    'x-osint-key': 'YOUR_OSINT_KEY',
    'Content-Type': 'application/json'
  }
};

// Alternative (RapidAPI):
// const options = {
//   method: 'POST',
//   hostname: 'google-checker2.p.rapidapi.com',
//   port: null,
//   path: '/check',
//   headers: {
//     'x-rapidapi-key': 'YOUR_RAPIDAPI_KEY',
//     'x-rapidapi-host': 'google-checker2.p.rapidapi.com',
//     'Content-Type': 'application/json'
//   }
// };

const req = https.request(options, function (res) {
  const chunks = [];

  res.on('data', function (chunk) {
    chunks.push(chunk);
  });

  res.on('end', function () {
    const body = Buffer.concat(chunks);
    console.log(body.toString());
  });
});

req.write(JSON.stringify({
  input: "test@gmail.com"
}));
req.end();