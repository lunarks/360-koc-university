var fireBase = fireBase || firebase;
var hasInit = false;
var config = {
    apiKey: "AIzaSyD3AM-8O5SWv2iSQX29pySvQ2om4ayNYFo",
    authDomain: "koc-university-360.firebaseapp.com",
    projectId: "koc-university-360",
    storageBucket: "koc-university-360.appspot.com",
    messagingSenderId: "769289120771",
    appId: "1:769289120771:web:bb3242dc8350d0cdb4b236"
  };
if(!hasInit){
    firebase.initializeApp(config);
    hasInit = true;
}


