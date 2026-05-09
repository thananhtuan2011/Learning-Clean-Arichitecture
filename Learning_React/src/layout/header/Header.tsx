import { Button } from 'antd'
import { useEffect } from 'react'

export default function Header() {
    useEffect(() => {
        console.log('header')
    }, [])
    return (
        <>
            <div className='font-bold text-2xl text-red-500'>header </div>
            <div>
                <Button type="link" htmlType="submit">
                    Hello Ant Design
                </Button>
                sss
            </div>
        </>
    )
}
