import { Button } from 'antd'
import React from 'react'

export default function TestChild(props: any) {
    const { name, onTest } = props
    let data = {
        name: "tuan",
        age: 20
    }
    return (
        <>

            <div>test-child</div>
            <span>
                {name}
            </span>
            <br></br>
            <Button onClick={() => onTest(data)}>
                click me
            </Button>
        </>

    )
}
