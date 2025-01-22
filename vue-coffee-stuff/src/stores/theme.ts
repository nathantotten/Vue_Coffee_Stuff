import { ref } from 'vue';
import { defineStore } from 'pinia';

export const useThemeStore = defineStore('themeSwitcher', () => {

  const currentTheme = ref('')

  if (!document.body.classList.contains('light') && !document.body.classList.contains('dark')) {
    document.body.classList.add('light');
    currentTheme.value = 'light'
  }

  function switchTheme() {
    console.log("Switching theme...");

    if (document.body.classList.contains('light')) {
      document.body.classList.remove('light');
      document.body.classList.add('dark');
      currentTheme.value = 'dark'
    } else if (document.body.classList.contains('dark')) {
      document.body.classList.remove('dark');
      document.body.classList.add('light');
      currentTheme.value = 'light'
    }
    // console.log(document.body.classList)
  }

  return { currentTheme, switchTheme };
});
