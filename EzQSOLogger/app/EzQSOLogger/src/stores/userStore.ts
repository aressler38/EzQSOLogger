import { defineStore } from "pinia";
import { getUserInfo, type ClientPrincipal } from "@/user/util";

export type UserStoreState = {
  user: null | ClientPrincipal;
};

export const useUserStore = defineStore("user", {
  state: (): UserStoreState => ({
    user: null,
  }),
  actions: {
    setUser(user: ClientPrincipal) {
      this.user = user;
    },
    async loadUser() {
      this.setUser(await getUserInfo());
    },
  },
});
