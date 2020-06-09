import { AuthenticationContext, adalFetch, withAdalLogin } from 'react-adal';
 
export const adalConfig = {
  tenant: '664bde91-a4de-495b-8628-194cd3a74810',
  clientId: '357928bc-5acd-41de-9afe-8bdeb98c9ca5',
  endpoints: {
    api: 'api://357928bc-5acd-41de-9afe-8bdeb98c9ca5',
  },
  cacheLocation: 'localStorage',
};
 
export const authContext = new AuthenticationContext(adalConfig);
 
export const adalApiFetch = (fetch, url, options) =>
  adalFetch(authContext, adalConfig.endpoints.api, fetch, url, options);
 
export const withAdalLoginApi = withAdalLogin(authContext, adalConfig.endpoints.api);