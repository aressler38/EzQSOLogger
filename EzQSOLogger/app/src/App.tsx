import React from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  async function debug1() {
    console.log('debug1')
    var r = await fetch('/api/debug/debug1', { method: 'get' })
    var data = await r.text()
    console.log(data)
  }
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          How to Learn React
        </a>
        <h1>HELLO WORLD 2</h1>
        <button onClick={() => debug1()}>Debug1</button>
      </header>
    </div>
  );
}

export default App;
