export type ClientPrincipal = {
  identityProvider: string;
  userId: string;
  userDetails: string;
  userRoles: string[];
  claims: {
    typ: string;
    val: string;
  }[];
};

export async function getUserInfo(): Promise<ClientPrincipal> {
  const response = await fetch("/.auth/me");
  const payload = await response.json();
  const { clientPrincipal } = payload;
  return clientPrincipal;
}
