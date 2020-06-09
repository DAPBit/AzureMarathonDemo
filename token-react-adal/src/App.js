import React from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  let ok=localStorage.getItem('adal.idtoken');
  return (
    <div className="App">
      <header className="App-header">
        
        <p >
          You are logged in.          
        </p>
        <div>
          What Is the the Token Structure?
<ul><li>
Header - Scope/issues/who</li>
<li>Payload - User/toke info</li>
<li>Signature - Security</li></ul>
</div>
        <div className="token">{ok}</div>
        
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
        </a>
      </header>
      <div>local</div>
    </div>
  );
}

export default App;
