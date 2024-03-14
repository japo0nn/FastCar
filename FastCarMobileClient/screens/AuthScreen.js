import React from 'react';
import { SafeAreaView, StyleSheet, Text, TextInput, View, Dimensions, Button, Pressable, Alert } from 'react-native';
import { inputColor, mainColor, secondColor, whiteColor, windowWidth } from '../_helpers/constant';

export default App = () => {

    return (
        <SafeAreaView style={{ flex: 1 }}>
            <View style={style.container}>
                <Text style={style.welcomeText}>Добро пожаловать!</Text>
                <View>
                    <TextInput
                        style={style.textInput}
                        placeholder='Имя пользователя' />
                    <TextInput
                        style={style.textInput}
                        placeholder='Пароль' />

                    <Pressable onPress={() => Alert.alert("Hello")} style={style.signBtn}>
                        <Text style={style.signBtnText}>Войти</Text>
                    </Pressable>
                </View>

                <View>
                    <Pressable>
                        <Text>Еще не зарегистрованы?</Text>
                        <Text>Зарегистрироваться</Text>
                    </Pressable>
                </View>
            </View>
        </SafeAreaView>
    )
}

const style = StyleSheet.create({
    container: {
        flex: 1,
        alignItems: 'center',
        justifyContent: 'center',
        backgroundColor: whiteColor
    },

    welcomeText: {
        color: mainColor,
        fontSize: 28,
        fontWeight: 'bold',
        marginBottom: 28
    },

    textInput: {
        borderRadius: 10,
        width: windowWidth / 1.5,
        height: windowWidth / 8,
        marginTop: 10,
        color: inputColor,
        backgroundColor: secondColor,
        textAlign: 'center',
    },
    
    signBtn: {
        borderRadius: 10,
        width: windowWidth / 1.5,
        height: windowWidth / 8,
        marginTop: 10,
        backgroundColor: mainColor,
        justifyContent: 'center'
    },

    signBtnText: {
        color: whiteColor,
        fontSize: 18,
        fontWeight: 'bold',
        textAlign: 'center',
    }
})