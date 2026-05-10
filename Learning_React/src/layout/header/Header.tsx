import { Button } from 'antd'
import { useEffect } from 'react'
import TestChild from '../Child/test-child'

export default function Header() {
    useEffect(() => {
        console.log('header')
    }, [])
    const Test = (data: any) => {
        console.log("data", data);

        alert(data.name)
    }
    return (
        <>
            <div className='font-bold text-2xl text-red-500'>header </div>
            <div>
                <Button type="link" htmlType="submit">
                    Hello Ant Design
                </Button>
                <TestChild name="tuan" onTest={(data: any) => Test(data)} />
            </div>
        </>
    )
}
