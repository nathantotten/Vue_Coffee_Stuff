import { ref } from 'vue';
import { defineStore } from 'pinia';

export const useThemeStore = defineStore('themeSwitcher', () => {

  const currentTheme = ref('')

  // console.log(!document.body.classList.contains('light'))
  // console.log(!document.body.classList.contains('dark'))
  // console.log(sessionStorage.getItem('theme') === null)
  // console.log(sessionStorage.getItem('theme'))
  if (!document.body.classList.contains('light') && !document.body.classList.contains('dark') && sessionStorage.getItem('theme') === null) {
    // If no theme, default to dark mode. Update body classlist and save to session storage.
    console.log('No theme found: defaulting to dark mode.')
    currentTheme.value = 'dark'
    document.body.classList.add(currentTheme.value);
    sessionStorage.setItem('theme', currentTheme.value);
  } else {
    // set the value from storage to the current theme (dark is a default incase session storage is null)
    currentTheme.value = sessionStorage.getItem('theme') || 'dark';
    document.body.classList.add(currentTheme.value)
  }

  function switchTheme() {
    console.log("Switching theme...");

    if (document.body.classList.contains('light')) {
      document.body.classList.remove('light');
      currentTheme.value = 'dark'
      document.body.classList.add(currentTheme.value);
      sessionStorage.setItem('theme', currentTheme.value);
    } else if (document.body.classList.contains('dark')) {
      document.body.classList.remove('dark');
      currentTheme.value = 'light'
      document.body.classList.add(currentTheme.value);
      sessionStorage.setItem('theme', currentTheme.value)
    }
    console.log(sessionStorage.getItem('theme'));
  }

  return { currentTheme, switchTheme };
});
