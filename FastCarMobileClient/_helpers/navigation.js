import React from 'react';
import { NavigationContainer } from "@react-navigation/native"
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import AuthScreen from '../screens/AuthScreen';


const Stack = createNativeStackNavigator()

export default Navigation = () => {
    return(
        <NavigationContainer>
            <Stack.Navigator>
                <Stack.Screen 
                    name = "Authorization"
                    component={AuthScreen}
                    options={{headerShown: false}}
                />
            </Stack.Navigator>
        </NavigationContainer>
    )
} 