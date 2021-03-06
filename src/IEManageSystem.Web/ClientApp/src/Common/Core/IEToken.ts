import IETool from 'Core/ToolLibrary/IETool'

export default class IEToken {
    static setToken(token: string, isRemember: boolean) {
        if(isRemember){
            return IETool.setCookie('ie_token', token, 7);
        }
        else{
            return IETool.setCookie('ie_token', token);
        }
    }

    static getToken() {
        return IETool.getCookie('ie_token');
    }

    static clearToken() {
        return IETool.delCookie('ie_token');
    }
}