import { useState } from 'react'
import './App.css'

function App() {
  const [] = useState(0)

  return (
    <>
      <div className='grid grid-cols-2 gap-4'>
        <div className='grid grid-cols gap-4'>
          <h1 className="text-2xl font-bold">My Location</h1>
        </div>
        <div className="flex flex-col items-center justify-center gap-4">
          <button onClick={() => alert("Test helloo")}>Get Location</button>
          <button onClick={() => alert("Valitse toinen")}>Delete</button>
        </div>
      </div>
    </>
  )
}

export default App
