import {NgModule} from '@angular/core'
import { BrowserModule } from '@angular/platform-browser';
import { App } from './app';
import { Another } from './another';
import { Child } from './child';


@NgModule({
    imports:[BrowserModule],
    declarations:[App,Another,Child],
    bootstrap:[App,Another]
})

export class AppModule{}