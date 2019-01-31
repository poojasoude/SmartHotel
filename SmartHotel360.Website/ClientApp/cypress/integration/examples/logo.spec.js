it('has a visible smarthotel logo', function() {
  cy.get('.sh-nav_menu-logo is-home').should('be.visible');
});