import { PolymerElement, html } from '@polymer/polymer';

class EventAddress extends PolymerElement {

    static get properties() {
        return {
            venue: String,
            address1: String,
            address2: String
        };
    }

    static get template() {
        return html`
            <address>
                <strong>[[venue]]</strong><br />
                [[address1]]<br />
                [[address2]]
            </address>
        `;
    }
}

customElements.define('event-address', EventAddress);