import { atom, useAtom } from 'jotai';
import {  Dimensions } from 'react-native';

export const ServerUrl = 'http://192.168.8.123:7144';
export const signedIn = atom(false);


// Сочетания цветов
export const mainColor = '#3399ff'; // Основой цвет для концентрации внимания пользователя
export const secondColor = '#bee7fa'; // Вторичный цвет. Использовать для Input
export const inputColor = '#333333'; // Цвет для текста Input

export const whiteColor = 'white';

export const windowHeight = Dimensions.get('window').height;
export const windowWidth = Dimensions.get('window').width;